using ProjectEuler.Models;

namespace ProjectEuler.Solvers
{
	public static class Problem1
	{
		public static AnswerViewModel GetAnswer()
		{
			var answer = new AnswerViewModel();

			for (int i = 0; i < 1000; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
					answer.AnswerInt += i;
			}

			return answer;
		}
	}
}