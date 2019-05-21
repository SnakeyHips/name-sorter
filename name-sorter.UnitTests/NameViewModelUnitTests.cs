using name_sorter.Common.Helpers;
using name_sorter.Common.Models;
using name_sorter.Common.ViewModels;
using name_sorter.Contracts.Models;
using System.Collections.Generic;
using Xunit;

namespace name_sorter.UnitTests
{
    public class NameViewModelUnitTests
    {
        [Fact]
        public void NameViewModelSortSuccess()
        {
            // Arrange
            var nameViewModel = new NameViewModel(new LogHelper());
            nameViewModel.Names = new List<IName>();
            nameViewModel.Names.Add(new Name()
            {
                FirstNames = "Jon",
                LastName = "Snow"
            });
            nameViewModel.Names.Add(new Name()
            {
                FirstNames = "Joe John",
                LastName = "Bloggs"
            });
            nameViewModel.Names.Add(new Name()
            {
                FirstNames = "Jane Mary",
                LastName = "Doe"
            });
            var expected = "Snow";

            // Act
            nameViewModel.SortNames();
            var actual = nameViewModel.Names[nameViewModel.Names.Count - 1].LastName;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NameViewModelSortFailure()
        {
            // Arrange
            var nameViewModel = new NameViewModel(new LogHelper());
            nameViewModel.Names = new List<IName>();
            nameViewModel.Names.Add(new Name()
            {
                FirstNames = "Jon",
                LastName = "Snow"
            });
            nameViewModel.Names.Add(new Name()
            {
                FirstNames = "Joe John",
                LastName = "Bloggs"
            });
            nameViewModel.Names.Add(new Name()
            {
                FirstNames = "Jane Mary",
                LastName = "Doe"
            });
            var expected = "Doe";

            // Act
            nameViewModel.SortNames();
            var actual = nameViewModel.Names[nameViewModel.Names.Count - 1].LastName;

            // Assert
            Assert.NotEqual(expected, actual);
        }
    }
}
