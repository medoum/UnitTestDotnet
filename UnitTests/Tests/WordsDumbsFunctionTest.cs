using System;
namespace UnitTests.Tests
{
	public static class WordsDumbsFunctionTest
	{
		//Naming Convention - ClassName_Methode_ExcepctedResult
		public static void WorldsDumbestFunction_ReturnPikachuIfzero_ReturnString()
		{
			try
			{
				//Arrange - Go get your variables, whatever you need , your classes, go get functions
				int num = 0;
                WordsDumbsFunction wordsDumbs = new WordsDumbsFunction();
				//Act - Execute this funtion
				string result = wordsDumbs.ReturnSPikachuIfZero(num);


                //Assert - Whatever ever is returned is it what you want
				if(result == "Pikachu")
				{
					Console.WriteLine("PASSED: WorldsDumbestFunction.ReturnPikachuIfzero_ReturnString");
				}
				else
				{
					Console.WriteLine("FAILED: WorldsDumbestFunction.ReturnPikachuIfzero_ReturnString");
				}
            }
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}
	}
}

