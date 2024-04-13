using AutoMapper;
using Forage.Core.Entities;
using Forage.Core.Repositories;
using Forage.Service.Dtos.Questions;
using Forage.Service.Dtos.Skills;
using Forage.Service.Responses;
using Forage.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Services.Implementations
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _repository;
        private readonly IMapper _mapper;

        public QuestionService(IQuestionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ApiResponse> CreateAsync(QuestionPostDto dto)
        {
            Question question = new Question
            {
                QuestionLanguages = dto.QuestionLanguages.Select(x => new QuestionLanguage
                {
                    LanguageId = x.LanguageId,
                    Title = x.Title,
                    Text = x.Text,
                }).ToList(),
            };
            await _repository.AddAsync(question);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = question
            };
        }

        public async Task<ApiResponse> GetAllAsync()
        {
            IEnumerable<Question> Questions = await _repository.GetAllAsync(x => !x.IsDeleted, "QuestionLanguages");
            return new ApiResponse
            {
                items = Questions,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Question? Question = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted, "QuestionLanguages");
            if (Question == null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
            QuestionUpdateDto dto = _mapper.Map<QuestionUpdateDto>(Question);
            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Question Question = await _repository.GetAsync(x => x.Id == id);
            if (Question is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Question.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Question
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, QuestionUpdateDto dto)
        {
            Question question = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (question is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }

            foreach (var lang in dto.QuestionLanguages)
            {
                var existingLanguage = question.QuestionLanguages.FirstOrDefault(x => x.LanguageId == lang.LanguageId);
                if (existingLanguage != null)
                {
                    existingLanguage.Title = lang.Title;
                    existingLanguage.Text = lang.Text;
                }
            }

            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = question
            };
        }
    }
}
