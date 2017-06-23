using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplyProcess.Models
{

    #region Class from Web API - find a way to share them

    /// <summary>
    /// Rules for a question.
    /// </summary>
    public class QuestionRule
    {
        public int RuleId { get; set; }
        public int QuestionId { get; set; }
        public int QuestionTypeId { get; set; }
        public string QuestionTypeName { get; set; }
        public string RuleName { get; set; }
        /// <summary>
        /// 1 = Block if true.
        /// 2 = Warn if true
        /// 3 = Follow up if true
        /// </summary>
        public int RuleTypeId { get; set; }
        public string RuleTypeName { get; set; }

        public int? EqualTo { get; set; }
        public int? GreaterThan { get; set; }
        public int? LessThan { get; set; }
        public string RuleMessage { get; set; }
        // Follow up question ids
        public List<int> FollowUpQuestionIds { get; set; }
    }

    /// <summary>
    /// Answer to a question.
    /// </summary>
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public int AttrRank { get; set; }
    }

    /// <summary>
    /// User answer to a question
    /// </summary>
    public class UserAnswer
    {
        public int QuestionId { get; set; }
        public int? IntAnswer { get; set; }
        public DateTime? DateAnswer { get; set; }
        public string StringAnswer { get; set; }
    }

    /// <summary>
    /// Definition of a question with possible answers and rules.
    /// </summary>
    public class InterviewQuestion
    {
        public int QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionText { get; set; }

        // Used for getting CategoryRank
        public string CategoryName { get; set; }

        // Sort 1
        public int CategoryRank { get; set; }

        // Sort 2
        public int QuestionRank { get; set; }

        // Sort 3
        public int CustomRank { get; set; }

        /// <summary>
        /// 1    Yes or No 
        /// 2    Multiple Choice 
        /// 3    Short Answer 
        /// 4    Essay 
        /// 5    Date Response 
        /// 6    Numerical Value 
        /// 7    Multiple Selection
        /// </summary>
        public int QuestionTypeId { get; set; }
        public string QuestionTypeName { get; set; }

        // Question must be answered if true
        public bool AnswerRequired { get; set; }

        // Show or hide question
        public bool Show { get; set; }

        // Number of positions applied to
        public int TotalCount { get; set; }

        // Number of positions the question applies to
        public int QuestionCount { get; set; }

        // The list of answers to a question that can be shown to a user.
        // Note: there can be more answers to a single question (multiple choice or multi select.)
        public List<Answer> Answers { get; set; }

        // The list of rules for a question
        public List<QuestionRule> Rules { get; set; }
    }

    /// <summary>
    /// An interview with id and questions for the interview.
    /// </summary>
    public class Interview
    {
        public int InterviewInstanceId { get; set; }
        public List<InterviewQuestion> Questions { get; set; }
    }
    #endregion
}
