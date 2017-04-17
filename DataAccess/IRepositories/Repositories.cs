using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface ICategoryRepository : IQuizRepository<Categories>
    {

    }
    public interface IQuestionLeveRepository : IQuizRepository<QuestionLevels>
    {

    }
    public interface IQuestionRepository : IQuizRepository<Questions>
    {

    }
    public interface IAnswerChoiceRepository : IQuizRepository<AnswerChoices>
    {

    }
    public interface ISubCategoryRepository : IQuizRepository<SubCategories>
    {

    }
}

