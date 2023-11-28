using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class SeleniumTests
{
    private IWebDriver driver;

    [SetUp]
    public void Initialize()
    {
        // Inicjalizacja przegl¹darki (w tym przypadku Chrome)
        driver = new ChromeDriver();
    }

    [Test]
    public void SwaggerPageNavigationTest()
    {
        // Nawi¹zanie do strony Swagger
        driver.Navigate().GoToUrl("https://localhost:7230/swagger/index.html");

        Console.WriteLine("TITLE: " + driver.Title);
        // Sprawdzenie, czy strona Swagger zosta³a prawid³owo za³adowana
        Assert.IsTrue(driver.Title.Contains("Swagger UI"));
    }

    [Test]
    public void getAvailableBookTest()
    {
        // Nawi¹zanie do strony Swagger
        driver.Navigate().GoToUrl("https://localhost:7230/swagger/index.html");
        waitForLoad();

        // Przyk³ad: Klikniêcie na sekcjê "Pet" i nastêpnie na operacjê "Add a new pet to the store"
        IWebElement getWindow = driver.FindElement(By.Id("operations-Book-get_api_Book_GetBook__id_"));

        IWebElement getButtonBig = getWindow.FindElement(By.TagName("button"));
        getButtonBig.Click();
        
        Thread.Sleep(500);

        var getButtons = getWindow.FindElements(By.TagName("button"));
        getButtons[1].Click();

        IWebElement inputIDField = getWindow.FindElement(By.TagName("input"));
        inputIDField.SendKeys("5");

        getButtons = getWindow.FindElements(By.TagName("button"));
        getButtons[2].Click();

        // Poczekaj na wykonanie operacji
        Thread.Sleep(3000);

        // Sprawdzenie, czy operacja zakoñczy³a siê pomyœlnie
        string retStr = getResponseFromCodeTag(getWindow);
        Assert.AreEqual("{  \"data\": {    \"id\": 5,    \"title\": \"Ergonomic Plastic Car\",    \"description\": \"" +
            "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support\",    \"" +
            "pages\": 699,    \"releaseDate\": \"2023-04-23T18:28:28\"  \"success\": true,  \"message\": \"Ok\"", retStr);
    }

    [Test]
    public void getEmptyBookTest()
    {
        // Nawi¹zanie do strony Swagger
        driver.Navigate().GoToUrl("https://localhost:7230/swagger/index.html");
        waitForLoad();

        // Przyk³ad: Klikniêcie na sekcjê "Pet" i nastêpnie na operacjê "Add a new pet to the store"
        IWebElement getWindow = driver.FindElement(By.Id("operations-Book-get_api_Book_GetBook__id_"));

        IWebElement getButtonBig = getWindow.FindElement(By.TagName("button"));
        getButtonBig.Click();

        Thread.Sleep(500);

        var getButtons = getWindow.FindElements(By.TagName("button"));
        getButtons[1].Click();

        IWebElement inputIDField = getWindow.FindElement(By.TagName("input"));
        inputIDField.SendKeys("2");

        getButtons = getWindow.FindElements(By.TagName("button"));
        getButtons[2].Click();

        // Poczekaj na wykonanie operacji
        Thread.Sleep(3000);
        string retStr = getResponseFromCodeTag(getWindow);
        // Sprawdzenie, czy operacja zakoñczy³a siê pomyœlnie
        Assert.AreEqual("Internal server error: Couldn't find book with ID: 2", retStr);
    }

    [Test]
    public void addBookTest()
    {
        // Nawi¹zanie do strony Swagger
        driver.Navigate().GoToUrl("https://localhost:7230/swagger/index.html");
        waitForLoad();

        // Przyk³ad: Klikniêcie na sekcjê "Pet" i nastêpnie na operacjê "Add a new pet to the store"
        IWebElement getWindow = driver.FindElement(By.Id("operations-Book-post_api_Book_AddBook"));

        IWebElement addButtonBig = getWindow.FindElement(By.TagName("button"));
        addButtonBig.Click();

        Thread.Sleep(500);

        var getButtons = getWindow.FindElements(By.TagName("button"));
        getButtons[1].Click();

        IWebElement textAreaField = getWindow.FindElement(By.TagName("textarea"));
        textAreaField.SendKeys(Keys.LeftControl + "a");
        textAreaField.SendKeys(Keys.Backspace);

        textAreaField.SendKeys("{" +
                              "\"id\": 1000," +
                              "\"title\": \"Test\"," +
                              "\"description\": \"TestDesc\"," +
                              "\"pages\": 20," +
                              "\"releaseDate\": \"2023-11-27T23:27:06.409Z\"" +
                            "}");
        getButtons = getWindow.FindElements(By.TagName("button"));
        getButtons[3].Click();

        // Poczekaj na wykonanie operacji
        Thread.Sleep(2000);

        // Sprawdzenie, czy operacja zakoñczy³a siê pomyœlnie
        string retStr = getResponseFromCodeTag(getWindow);
        Console.WriteLine(retStr);
        Assert.AreEqual("{  \"id\": 1000,  \"title\": \"Test\",  \"description\": \"TestDesc\",  \"pages\": 20,  \"releaseDate\": \"2023-11-27T23:27:06.409Z\"", retStr);
    }

    [Test]
    public void deleteBookTest()
    {
        // Nawi¹zanie do strony Swagger
        driver.Navigate().GoToUrl("https://localhost:7230/swagger/index.html");
        waitForLoad();

        // Przyk³ad: Klikniêcie na sekcjê "Pet" i nastêpnie na operacjê "Add a new pet to the store"
        IWebElement getWindow = driver.FindElement(By.Id("operations-Book-delete_api_Book_DeleteBook__id_"));

        IWebElement addButtonBig = getWindow.FindElement(By.TagName("button"));
        addButtonBig.Click();

        Thread.Sleep(500);

        var getButtons = getWindow.FindElements(By.TagName("button"));
        getButtons[1].Click();

        IWebElement inputIDField = getWindow.FindElement(By.TagName("input"));
        inputIDField.SendKeys("1000");

        getButtons = getWindow.FindElements(By.TagName("button"));
        getButtons[2].Click();

        // Poczekaj na wykonanie operacji
        Thread.Sleep(2000);

        // Sprawdzenie, czy operacja zakoñczy³a siê pomyœlnie
        string retStr = getResponseFromCodeTag(getWindow);
        Assert.AreEqual("{  \"data\": null,  \"success\": true,  \"message\": \"Book deleted successfully\"", retStr);
    }

    [Test]
    public void bookUpdateTest()
    {
        // Nawi¹zanie do strony Swagger
        driver.Navigate().GoToUrl("https://localhost:7230/swagger/index.html");
        waitForLoad();

        // Przyk³ad: Klikniêcie na sekcjê "Pet" i nastêpnie na operacjê "Add a new pet to the store"
        IWebElement getWindow = driver.FindElement(By.Id("operations-Book-put_api_Book_PutBook__id_"));

        IWebElement addButtonBig = getWindow.FindElement(By.TagName("button"));
        addButtonBig.Click();

        Thread.Sleep(500);

        var getButtons = getWindow.FindElements(By.TagName("button"));
        getButtons[1].Click();

        IWebElement inputIDField = getWindow.FindElement(By.TagName("input"));
        inputIDField.SendKeys("1000");

        IWebElement textAreaField = getWindow.FindElement(By.TagName("textarea"));
        textAreaField.SendKeys(Keys.LeftControl + "a");
        textAreaField.SendKeys(Keys.Backspace);

        textAreaField.SendKeys("{" +
                              "\"id\": 1000," +
                              "\"title\": \"TestUpdated\"," +
                              "\"description\": \"TestDescUpdated\"," +
                              "\"pages\": 30," +
                              "\"releaseDate\": \"2023-11-24T23:27:07.409Z\"" +
                            "}");

        getButtons = getWindow.FindElements(By.TagName("button"));
        getButtons[3].Click();

        // Poczekaj na wykonanie operacji
        Thread.Sleep(2000);

        // Sprawdzenie, czy operacja zakoñczy³a siê pomyœlnie
        string retStr = getResponseFromCodeTag(getWindow);
        Console.WriteLine(retStr);
        Assert.AreEqual("{  \"data\": null,  \"success\": true,  \"message\": \"Book updated successfully\"", retStr);
    }

    public void waitForLoad()
    {
        Thread.Sleep(5000);
    }

    public string getResponseFromCodeTag(IWebElement window)
    {
        string str = "";
        var codeTag = window.FindElements(By.TagName("code"));
        var spanElements = codeTag[1].FindElements(By.TagName("span"));

        foreach (var xd in spanElements)
            str += xd.Text;

        return str;
    }


    [TearDown]
    public void TearDown()
    {
        // Zamkniêcie przegl¹darki po zakoñczeniu testów
        driver.Quit();
    }
}