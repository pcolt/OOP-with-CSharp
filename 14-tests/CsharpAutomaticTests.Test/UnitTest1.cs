// To create a test project I can use 'dotnet new mstest'

namespace CsharpAutomaticTests.Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void initial_state() {
        var sll = new StringLinkedList();
        Assert.AreEqual(0, sll.Count);
    }

    [TestMethod]
    public void adding_elements_updates_Count() {
        var sll = new StringLinkedList();
        sll.Add("s0");
        Assert.AreEqual(1, sll.Count);
        sll.Add("s1");
        Assert.AreEqual(2, sll.Count);
    }

    [TestMethod]
    public void one_element_is_added_and_retrieved() {
        var sll = new StringLinkedList();
        sll.Add("s0");
        Assert.AreEqual("s0", sll.Get(0));
    }

    [TestMethod]
    public void two_elements_are_added_and_retrieved() {
        var sll = new StringLinkedList();
        sll.Add("s0");
        sll.Add("s1");
        Assert.AreEqual("s0", sll.Get(0));
        Assert.AreEqual("s1", sll.Get(1));
    }

    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void get_negative_index_throws_error() {
        var sll = new StringLinkedList();
        sll.Get(-1);
    }

    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void get_zero_index_out_of_range_throws_error() {
        var sll = new StringLinkedList();
        sll.Get(0);
    }

    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void get_index_out_of_range_throws_error() {
        var sll = new StringLinkedList();
        sll.Get(1);
    }

    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void get_index_out_of_range_throws_error2() {
        var sll = new StringLinkedList();
        sll.Add("s0");
        sll.Get(2);
    }

    [TestMethod]
    public void removing_elements_updates_Count() {
        var sll = new StringLinkedList();
        sll.Add("s0");
        sll.Add("s1");
        sll.Add("s2");
        sll.Remove("s2");
        Assert.AreEqual(2, sll.Count);
        sll.Remove("s1");
        Assert.AreEqual(1, sll.Count);
        sll.Remove("s0");
        Assert.AreEqual(0, sll.Count);
        sll.Add("s0");
        sll.Add("s1");
        sll.Add("s2");
        sll.Add("s3");
        sll.Remove("s0");
        sll.Remove("s2");
        Assert.AreEqual(2, sll.Count);
        Assert.AreEqual("s1", sll.Get(0));
        Assert.AreEqual("s3", sll.Get(1));
    }

    [TestMethod]
    public void removing_non_present_elements_does_not_have_effect() {
        var sll = new StringLinkedList();
        sll.Add("s0");
        sll.Add("s1");
        sll.Add("s2");
        sll.Remove("s3");
        Assert.AreEqual(3, sll.Count);
    }
}