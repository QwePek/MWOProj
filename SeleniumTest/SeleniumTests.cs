using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class SeleniumTests
{
    private IWebDriver driver;

    [SetUp]
    public void Initialize()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArguments("--ignore-ssl-errors=yes");
        options.AddArguments("ignore-certificate-errors");
        driver = new ChromeDriver(options);
    }

    [Test]
    public void PageNavigationTest()
    {
        driver.Navigate().GoToUrl("https://localhost:7230");
        Console.WriteLine(driver.Url);
        Console.WriteLine(driver.PageSource);
        Assert.IsTrue(driver.Title.Contains("Get All books"));

        driver.Navigate().GoToUrl("https://localhost:7230/AddBook");
        Assert.IsTrue(driver.Title.Contains("Add book"));

        driver.Navigate().GoToUrl("https://localhost:7230/UpdateBook");
        Assert.IsTrue(driver.Title.Contains("Update book"));

        driver.Navigate().GoToUrl("https://localhost:7230/DeleteBook");
        Assert.IsTrue(driver.Title.Contains("Delete book"));

        driver.Navigate().GoToUrl("https://localhost:7230/BookForm");
        Assert.IsTrue(driver.Title.Contains("Get book"));
    }

    [Test]
    public void addBookTest()
    {
        // Nawi¹zanie do strony Swagger
        driver.Navigate().GoToUrl("https://localhost:7230/AddBook");
        waitForLoad();

        var ID = driver.FindElement(By.Id("bookId"));
        var Title = driver.FindElement(By.Id("title"));
        var Descr = driver.FindElement(By.Id("description"));
        var Pages = driver.FindElement(By.Id("pages"));
        var Date = driver.FindElement(By.Id("releaseDate"));

        ID.SendKeys("1000");
        Title.SendKeys("Test");
        Descr.SendKeys("TestDesc");
        Pages.SendKeys("20");
        Date.SendKeys("11272023");

        var submitButton = driver.FindElement(By.TagName("button"));
        submitButton.Click();

        // Poczekaj na wykonanie operacji
        waitForLoad();

        var result = driver.FindElement(By.Id("result"));
        Assert.AreEqual("Book added successfully with ID: 1000", result.Text);
    }

    [Test]
    public void bookGetTest()
    {
        driver.Navigate().GoToUrl("https://localhost:7230/BookForm");
        waitForLoad();

        IWebElement inputIDField = driver.FindElement(By.Id("bookId"));
        inputIDField.SendKeys("1000");

        var submitButton = driver.FindElement(By.TagName("button"));
        submitButton.Click();

        // Poczekaj na wykonanie operacji
        waitForLoad();

        var ID = driver.FindElement(By.Id("retID"));
        var Title = driver.FindElement(By.Id("retTitle"));
        var Descr = driver.FindElement(By.Id("retDescr"));
        var Pages = driver.FindElement(By.Id("retPages"));
        var Date = driver.FindElement(By.Id("retDate"));

        Assert.AreEqual("1000", ID.Text);
        Assert.AreEqual("Test", Title.Text);
        Assert.AreEqual("TestDesc", Descr.Text);
        Assert.AreEqual("20", Pages.Text);
        Assert.AreEqual("27.11.2023 00:00:00", Date.Text);
    }

    [Test]
    public void getEmptyBookTest()
    {
        // Nawi¹zanie do strony Swagger
        driver.Navigate().GoToUrl("https://localhost:7230/BookForm");
        waitForLoad();

        IWebElement inputIDField = driver.FindElement(By.Id("bookId"));
        inputIDField.SendKeys("1001");

        var submitButton = driver.FindElement(By.TagName("button"));
        submitButton.Click();

        // Poczekaj na wykonanie operacji
        waitForLoad();

        var Result = driver.FindElement(By.Id("retMsg"));
        Assert.AreEqual("Couldn't find book with ID: 1001", Result.Text);
    }

    [Test]
    public void deleteBookTest()
    {
        driver.Navigate().GoToUrl("https://localhost:7230/DeleteBook");
        waitForLoad();

        IWebElement inputIDField = driver.FindElement(By.Id("bookId"));
        inputIDField.SendKeys("1000");

        var submitButton = driver.FindElement(By.TagName("button"));
        submitButton.Click();

        // Poczekaj na wykonanie operacji
        waitForLoad();

        var result = driver.FindElement(By.Id("result"));
        Assert.AreEqual("Book deleted successfully with ID: 1000", result.Text);
    }

    [Test]
    public void bookUpdateTest()
    {
        // Nawi¹zanie do strony Swagger
        driver.Navigate().GoToUrl("https://localhost:7230/UpdateBook");
        waitForLoad();

        var ID = driver.FindElement(By.Id("bookId"));
        var Title = driver.FindElement(By.Id("title"));
        var Descr = driver.FindElement(By.Id("description"));
        var Pages = driver.FindElement(By.Id("pages"));
        var Date = driver.FindElement(By.Id("releaseDate"));

        ID.SendKeys("1000");
        Title.SendKeys("TestUpdated");
        Descr.SendKeys("TestDescUpdated");
        Pages.SendKeys("25");
        Date.SendKeys("11282023");

        var submitButton = driver.FindElement(By.TagName("button"));
        submitButton.Click();

        // Poczekaj na wykonanie operacji
        waitForLoad();

        var result = driver.FindElement(By.Id("result"));
        Assert.AreEqual("Book updated successfully with ID: 1000", result.Text);

        //Sprawdzenie czy dodalo sie odpowiednio
        driver.Navigate().GoToUrl("https://localhost:7230/BookForm");
        waitForLoad();

        IWebElement inputIDField = driver.FindElement(By.Id("bookId"));
        inputIDField.SendKeys("1000");
        
        submitButton = driver.FindElement(By.TagName("button"));
        submitButton.Click();

        // Poczekaj na wykonanie operacji
        waitForLoad();

        ID = driver.FindElement(By.Id("retID"));
        Title = driver.FindElement(By.Id("retTitle"));
        Descr = driver.FindElement(By.Id("retDescr"));
        Pages = driver.FindElement(By.Id("retPages"));
        Date = driver.FindElement(By.Id("retDate"));

        Assert.AreEqual("1000", ID.Text);
        Assert.AreEqual("TestUpdated", Title.Text);
        Assert.AreEqual("TestDescUpdated", Descr.Text);
        Assert.AreEqual("25", Pages.Text);
        Assert.AreEqual("28.11.2023 00:00:00", Date.Text);
    }
    
    void waitForLoad()
    {
        Thread.Sleep(3000);
    }

    [TearDown]
    public void TearDown()
    {
        // Zamkniêcie przegl¹darki po zakoñczeniu testów
        driver.Quit();
    }
}