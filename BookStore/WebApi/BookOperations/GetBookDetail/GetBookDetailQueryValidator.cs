using System;
using System.Linq;
using AutoMapper;
using FluentValidation;
using WebApi.DBOperations;

namespace WebApi.BookOperations.GetBookDetailQuery
{
    public class GetBookDetailQueryValidator : AbstractValidator<GetBookDetailQuery>
    {
      public GetBookDetailQueryValidator()
      {
        RuleFor(query => query.BookId).GreaterThan(0);
      }
    }
}