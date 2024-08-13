using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById
{
    public class GetPetByIdUseCase
    {
        public ResponsePetJson Execute(int id)
        {
            return new ResponsePetJson
            {
                Id = id,
                Name = "teste",
                Birthday = DateTime.Now,
                Type = 0
            };
        }
    }
}
