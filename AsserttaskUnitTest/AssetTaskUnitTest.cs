using Asserttask;
using System.Collections.Generic;
using Xunit;
using Moq;

namespace AsserttaskUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void To_Check_Whether_List_Is_Null()
        {//Arrange
            List<int> list1 = new List<int>() { 10, 20, 30 };
            List<int> list2 = new List<int>();

            ListOfNumber listofnumber = new ListOfNumber();
            //Act
            list1 = listofnumber.Numberlist(list1);
            listofnumber.checklistwhetherlistisnull(list2);

            //Assert
            Assert.Empty(list2);
           
            Assert.NotNull(list1);
           


        }

        [Fact]
        public void To_Check_Whether_List_It_Is_Not_Empty()
        {//Arrange
            ListOfNumber listofnumber = new ListOfNumber();
            List<int> list1 = new List<int>() { 10, 20, 30 };
            //Act
            listofnumber.checklistwhetherlistisnull(list1);
            //Assert
            Assert.NotEmpty(list1);

        }

        [Theory]
        [InlineData(10, 20, 30)]
        public void To_Check_Whether_List_Is_NotNull(params int[] checklist)
        {
             List<int> list1 = new List<int>() { 10, 20, 30 };

            Assert.NotNull(checklist);
        }



        [Fact]
        public void Get_Code()
        {
            var expected = new List<int>();
            expected.AddRange(new[] { 100, 400, 200, 900, 2300, 1900 });

            var actual = new List<int>();
            actual.AddRange(new[] { 100, 400, 200, 900, 2300, 1900 });

           Assert.Equal(expected, actual);
           


        }
    }

}

