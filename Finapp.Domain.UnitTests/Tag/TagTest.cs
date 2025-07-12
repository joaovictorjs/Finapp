using System;
using Bogus;
using Shouldly;
using DomainTag = Finapp.Domain.Tag.Tag;

namespace Finapp.Domain.UnitTests.Tag;

public class TagTest
{
    private Faker _faker = new Faker();

    [Fact(DisplayName = "Should throw ArgumentNullException when Description is null")]
    public void ShouldThrowArgumentNullExceptionWhenDescriptionIsNull()
    {
        // Arrange
        var expectedMessage = "Description can not be null or empty.";
        var expectedParamName = "description";

        // Act
        var createTag = () => new DomainTag(null!);

        // Assert
        createTag
            .ShouldThrow<ArgumentNullException>()
            .ShouldSatisfyAllConditions(
                ex => ex.Message.ShouldStartWith(expectedMessage),
                ex => ex.ParamName.ShouldBe(expectedParamName)
            );
    }
}
