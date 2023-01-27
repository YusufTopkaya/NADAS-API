using Nadas.API.Business.Interfaces;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.DTO.DTOs.NotificationDtos;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.Business.Concrete
{
    public class AnswerManager : GenericManager<Answer>, IAnswerService
    {
        private readonly IAnswerDal _answerDal;
        private readonly IUserService _userManager;
        private readonly INotificationService _notificationManager;
        private readonly IQuestionService _questionManager;


        public AnswerManager(IGenericDal<Answer> genericDal, IAnswerDal answerDal, IUserService userManager, INotificationService notificationManager, IQuestionService questionManager) : base(genericDal)
        {
            _answerDal = answerDal;
            _userManager = userManager;
            _notificationManager = notificationManager;
            _questionManager = questionManager;
        }

        public async Task<Answer> AddAnswerAsync(Answer answer)
        {
            await _answerDal.AddAsync(answer);
            var sender =await _userManager.FindById(answer.UserId);
            answer.User = sender;
            Question question = await _questionManager.FindById(answer.QuestionId);
            var recipient =await _userManager.FindById(question.UserId);
            var questionText = question.Title.Length > 50 ? question.Title.Substring(0,50) + "..." : question.Title;
            var title = "\""+ questionText+ "\" sorunuza yeni bir cevap aldınız.";
            var message = sender.Name + " " + sender.Surname + ": " + answer.Content.Text;
            if (sender.Id != recipient.Id)
            {
                NotificationCreateDto notificationCreateDto = new() { Sender = sender, Recipient = recipient, Title = title, Message = message};
                _notificationManager.NotifyUser(notificationCreateDto);
            }
            return answer;
            
        }

        public Task<List<Answer>> GetAllByQuestionIdAsync(int id)
        {
            return _answerDal.GetAllByQuestionIdAsync(id);
        }

        public Task<List<Answer>> GetAllLoadedAsync()
        {
            return _answerDal.GetAllLoadedAsync();
        }
    }
}
