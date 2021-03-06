using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmailService
    {
        IDataResult<List<Email>> GetList();

        IDataResult<Email> Get(int id);

        IResult Add(Email email);

        IResult Update(Email email);

        IResult Delete(Email email);
    }
}