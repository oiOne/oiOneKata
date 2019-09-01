using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace oiOneKata
{
    public class PaginationHelperTheorys
    {
        private readonly IList<int> collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        private PagnationHelper<int> helper;

        public PaginationHelperTheorys()
        {
            helper = new PagnationHelper<int>(collection, 10);
        }

        [Theory]
        [InlineData(-1, -1)]
        [InlineData(1,10)]
        [InlineData(3,-1)]
        public void PageItemCountTheory(int pageIndex, int expected)
        {
            Assert.Equal(expected, helper.PageItemCount(pageIndex));
        }

        [Theory]
        [InlineData(-1,-1)]
        [InlineData(12,1)]
        [InlineData(24,-1)]
        public void PageIndexTheory(int itemIndex, int expected)
        {
            Assert.Equal(expected, helper.PageIndex(itemIndex));
        }

        [Fact]
        public void ItemCountTheory()
        {
            Assert.Equal(24, helper.ItemCount);
        }

        [Fact]
        public void PageCountTheory()
        {
            Assert.Equal(3, helper.PageCount);
        }
    }
}
