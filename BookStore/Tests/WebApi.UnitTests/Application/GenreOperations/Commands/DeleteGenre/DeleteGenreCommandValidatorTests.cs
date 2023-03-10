using FluentAssertions;
using TestSetup;
using WebApi.Application.GenreOperations.DeleteGenre;
using Xunit;

namespace Application.GenreOperations.Commands.DeleteGenre
{
    public class DeleteGenreCommandValidatorTests : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
      public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(int genreId)
      {
        DeleteGenreCommand command = new DeleteGenreCommand(null);
        command.GenreId=genreId;
        
        DeleteGenreCommandValidator validator = new DeleteGenreCommandValidator();
        var result = validator.Validate(command);

        result.Errors.Count.Should().BeGreaterThan(0);
      }
      [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
      public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErrors(int genreId)
      {
        DeleteGenreCommand command = new DeleteGenreCommand(null);
        command.GenreId=genreId;
        
        DeleteGenreCommandValidator validator = new DeleteGenreCommandValidator();
        var result = validator.Validate(command);

        result.Errors.Count.Should().Be(0);
      }      
    }
}