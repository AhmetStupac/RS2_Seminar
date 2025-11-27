using eCommerce.Model.Requests;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using eCommerce.Services.Interface;
using MapsterMapper;

namespace eCommerce.Services
{
    public class PersonalTrainerService : BaseCRUDService<Database.PersonalTrainer, PersonalTrainerSearchObject, Database.PersonalTrainer, PersonalTrainerUpsertRequest, PersonalTrainerUpsertRequest>, IPersonalTrainerService
    {
        public PersonalTrainerService(eCommerceDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
