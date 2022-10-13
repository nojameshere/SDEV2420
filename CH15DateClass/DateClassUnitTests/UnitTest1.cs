using CH15DateClass;
namespace DateClassUnitTests;


[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        //Instantiating Dates

        Date date1 = new Date(1997, 11, 4);//All Valid Data
        Assert.AreEqual(date1.ToString(), "11/4/1997");
        Date date2 = new Date(1922, 3, 288);//Invalid Day
        Assert.AreEqual(date2.ToString(), "3/1/1922");
        Date date3 = new Date(1, 90, 9402018);//All invalid Data
        Assert.AreEqual(date3.ToString(), "1/1/2001");
        Date date4 = new Date(1756, 8, 25);//Invalid Year
        Assert.AreEqual(date4.ToString(), "8/25/2001");
        Date date5 = new Date(2045, 13, 4);//Invalid Month
        Assert.AreEqual(date5.ToString(), "1/4/2045");
        Date date6 = new Date(1875, 11, 31);//Invalid day for the selected month
        Assert.AreEqual(date6.ToString(), "11/1/1875");
        Date date7 = new Date(17, 1, 1);//Valid 2-digit year
        Assert.AreEqual(date7.ToString(), "1/1/2017");
        Date date8 = new Date(235, 3, 6);
        Assert.AreEqual(date8.ToString(), "3/6/2001");

        ////Adding Days Testing | All dates will have 5 days added to them

        Date addDate1 = new Date(2020, 1, 15);//Date in middle of month
        addDate1.addDay(5);
        Assert.AreEqual(addDate1.ToString(), "1/20/2020");
        Date addDate2 = new Date(2020, 1, 29);//Date near end of 31 day month
        addDate2.addDay(5);
        Assert.AreEqual(addDate2.ToString(), "2/3/2020");
        Date addDate3 = new Date(2020, 11, 29);//Date near end of 30 day month
        addDate3.addDay(5);
        Assert.AreEqual(addDate3.ToString(), "12/4/2020");
        Date addDate4 = new Date(2020, 2, 27);//End of feb (on a leap year)
        addDate4.addDay(5);
        Assert.AreEqual(addDate4.ToString(), "3/3/2020");
        Date addDate5 = new Date(2021, 2, 27);//End of feb (not a leap year)
        addDate5.addDay(5);
        Assert.AreEqual(addDate5.ToString(), "3/4/2021");
        Date addDate6 = new Date(2021, 12, 30);//Near end of year.
        addDate6.addDay(5);
        Assert.AreEqual(addDate6.ToString(), "1/4/2022");
    }
}
