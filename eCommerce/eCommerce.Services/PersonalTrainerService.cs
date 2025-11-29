using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using eCommerce.Services.Interface;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Services
{
    public class PersonalTrainerService : BaseCRUDService<PersonalTrainerResponse, PersonalTrainerSearchObject, PersonalTrainer, PersonalTrainerUpsertRequest, PersonalTrainerUpsertRequest>, IPersonalTrainerService
    {
        public PersonalTrainerService(eCommerceDbContext context, IMapper mapper)
            : base(context, mapper)
        {

        }


        protected override IQueryable<Database.PersonalTrainer> ApplyFilter(IQueryable<Database.PersonalTrainer> query, PersonalTrainerSearchObject search)
        {

            return query.Include(pt=>pt.User);
        }
    }
}
