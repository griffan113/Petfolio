using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById;

public class GetPetByIdUseCase {
    public ResponsePetJson Execute(int id) {
        return new ResponsePetJson {
            Id = id,
            Name = "Dog",
            Birthday = new DateTime(year: 2025, month: 01, day: 01),
            Type = PetType.Dog,
        };
    }
}