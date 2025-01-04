using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetAll;

public class GetAllPetsUseCase {
    public List<ResponseShortPetJson> Execute() {
        return [
            new() {
                Id = 1,
                Name = "Dog",
                Type = PetType.Dog
            },

            new() {
                Id = 2,
                Name = "Cat",
                Type = PetType.Cat
            }
        ];
    }
}