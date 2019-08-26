using microsoftWebDevInterview;
using System;
using System.Collections.Generic;
using Xunit;

namespace DeleteDuplicateLinkedListUnitTest
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {

            var ll = new linkedListHelper();
            ll.Add("E");
            ll.Add("B");
            ll.Add("E");
            ll.Add("E");
            ll.Add("B");
            ll.Add("A");
            ll.Add("A");
            ll.Add("B");
            string result = "";
            Node node = (Node)ll.RemoveDuplicate();
            while (node != null)
            {
               
                    if (string.IsNullOrEmpty(result))
                        result = node.Data.ToString() + "->";
                    else
                     if (node.Next != null)
                        {
                            result = string.Concat(result, node.Data.ToString() + "->");
                        }
                        else {
                            result = string.Concat(result, node.Data.ToString());
                        }
                node = node.Next;
            }
            Assert.Equal("E->B->E->B->A->A", result);

        }
    }
}
