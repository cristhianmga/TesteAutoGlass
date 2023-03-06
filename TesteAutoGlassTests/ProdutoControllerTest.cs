using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAutoGlass.Controllers;
using TesteAutoGlassNegocio.DTO;
using TesteAutoGlassNegocio.Interface;
using TesteAutoGlassNegocio.Services;
using Xunit;

namespace TesteAutoGlassTests
{
    public class ProdutoControllerTest
    {
        private readonly IProdutosService _mockService;
        private readonly ProdutoController _controller;
        public ProdutoControllerTest() 
        {
            _mockService = new Mock<IProdutosService>().Object;
            _controller = new ProdutoController(_mockService);
        }


        [Fact]
        public async void SalvarProdutoServico_Ok()
        {
            Moq.Mock<IProdutosService> mock = new Moq.Mock<IProdutosService>();
            mock.Setup(x => x.SalvarAsync(It.IsAny<ProdutoDTO>())).Returns(It.IsAny<Task<ProdutoDTO>>());
            ProdutoDTO dTO = new ProdutoDTO();
            var retorno = await _controller.Salvar(dTO);
            Xunit.Assert.IsType<OkObjectResult>(retorno);
            Xunit.Assert.NotNull(retorno);
        }

        //[Fact]
        //public async void AtualizarProdutoServico_Ok()
        //{
        //    Moq.Mock<IProdutosService> mock = new Moq.Mock<IProdutosService>();
        //    mock.Setup(x => x.SalvarAsync(It.IsAny<ProdutoDTO>())).Returns(It.IsAny<Task<ProdutoDTO>>());
        //    ProdutoDTO dTO = new ProdutoDTO();
        //    var retorno = await _controller.Salvar(dTO);
        //    Xunit.Assert.IsType<OkObjectResult>(retorno);
        //    Xunit.Assert.NotNull(retorno);
        //}

        //[Fact]
        //public async void SalvarProdutoServico_Ok()
        //{
        //    Moq.Mock<IProdutosService> mock = new Moq.Mock<IProdutosService>();
        //    mock.Setup(x => x.SalvarAsync(It.IsAny<ProdutoDTO>())).Returns(It.IsAny<Task<ProdutoDTO>>());
        //    ProdutoDTO dTO = new ProdutoDTO();
        //    var retorno = await _controller.Salvar(dTO);
        //    Xunit.Assert.IsType<OkObjectResult>(retorno);
        //    Xunit.Assert.NotNull(retorno);
        //}

        //[Fact]
        //public async void SalvarProdutoServico_Ok()
        //{
        //    Moq.Mock<IProdutosService> mock = new Moq.Mock<IProdutosService>();
        //    mock.Setup(x => x.SalvarAsync(It.IsAny<ProdutoDTO>())).Returns(It.IsAny<Task<ProdutoDTO>>());
        //    ProdutoDTO dTO = new ProdutoDTO();
        //    var retorno = await _controller.Salvar(dTO);
        //    Xunit.Assert.IsType<OkObjectResult>(retorno);
        //    Xunit.Assert.NotNull(retorno);
        //}

        //[Fact]
        //public async void SalvarProdutoServico_Ok()
        //{
        //    Moq.Mock<IProdutosService> mock = new Moq.Mock<IProdutosService>();
        //    mock.Setup(x => x.SalvarAsync(It.IsAny<ProdutoDTO>())).Returns(It.IsAny<Task<ProdutoDTO>>());
        //    ProdutoDTO dTO = new ProdutoDTO();
        //    var retorno = await _controller.Salvar(dTO);
        //    Xunit.Assert.IsType<OkObjectResult>(retorno);
        //    Xunit.Assert.NotNull(retorno);
        //}

        //[Fact]
        //public async void SalvarProdutoServico_BadRequest()
        //{
        //    Moq.Mock<IProdutosService> mock = new Moq.Mock<IProdutosService>();
        //    mock.Setup(x => x.SalvarAsync(It.IsAny<ProdutoDTO>())).Throws<Exception>();
        //    ProdutoDTO dTO = new ProdutoDTO();
        //    IActionResult retorno = await _controller.Salvar(dTO);
        //    Xunit.Assert.IsType<BadRequestObjectResult>(retorno);
        //}

    }
}
