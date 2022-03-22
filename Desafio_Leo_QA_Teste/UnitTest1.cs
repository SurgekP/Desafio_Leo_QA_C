using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestAutomatizadoProjetoInicial
{
    public class LoginAdicionarNovoCurso
    {
        [Fact]
        public void TesteAdicionarNovoCurso()
        {
            //arrange - dado que estou em um navegador Chrome aberto

            IWebDriver navegador = new ChromeDriver();

            //act - quando navego para a URL https://sandbox.moodledemo.net/login/index.php

            navegador.Navigate().GoToUrl("https://sandbox.moodledemo.net/login/index.php");

            //assert  - então validar que o login seja realizado e um novo curso seja cadastrado com sucesso 

            navegador.FindElement(By.Id("username")).Click();
            navegador.FindElement(By.Id("username")).SendKeys("admin");
            navegador.FindElement(By.Id("password")).Click();
            navegador.FindElement(By.Id("password")).SendKeys("sandbox");
            navegador.FindElement(By.Id("loginbtn")).Click();
            navegador.Navigate().GoToUrl("https://sandbox.moodledemo.net/");
            navegador.FindElement(By.XPath("//div[@id='nav-drawer']/nav[2]/ul/li/a/div/div/span[2]")).Click();
            navegador.FindElement(By.LinkText("Courses")).Click();
            navegador.FindElement(By.LinkText("Add a new course")).Click();
            navegador.FindElement(By.Id("id_fullname")).Click();
            navegador.FindElement(By.Id("id_fullname")).Click();
            navegador.FindElement(By.Id("id_fullname")).SendKeys("Adicionar Curso Teste");
            navegador.FindElement(By.Id("id_shortname")).SendKeys("Desafio Leo QA");
            navegador.FindElement(By.Id("id_idnumber")).Click();
            navegador.FindElement(By.Id("id_idnumber")).SendKeys("2022");
            navegador.FindElement(By.Id("id_saveanddisplay")).Click();

        }
    }
}