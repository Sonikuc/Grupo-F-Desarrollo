using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCABPagaloTodoMS.Application.Commands;
using UCABPagaloTodoMS.Application.Queries;
using UCABPagaloTodoMS.Controllers;
using UCABPagaloTodoMS.Tests.MockData;
using Xunit;

namespace UCABPagaloTodoMS.Tests.UnitTests.Controllers
{
    public class ServiceDeleteControllerTest
    {
        private readonly ServiceDeleteController _controller;
        private readonly Mock<IMediator> _mediatorMock;
        private readonly Mock<ILogger<ServiceDeleteController>> _loggerMock;

        public ServiceDeleteControllerTest()
        {
            _loggerMock = new Mock<ILogger<ServiceDeleteController>>();
            _mediatorMock = new Mock<IMediator>();
            _controller = new ServiceDeleteController(_loggerMock.Object, _mediatorMock.Object);

        }
       
        [Fact(DisplayName = "ServiceDelete exception")]
        public async Task serviceDeleteex()
        {
            //Arrage
            var request = BuildDataServicesContextFaker.ServiceDeleteRequest();

            _mediatorMock.Setup(x => x.Send(It.IsAny<ServiceDeleteCommand>(), default(CancellationToken)))
                             .ThrowsAsync(new Exception());

            
            //Act
            Func<Task> result = async () => await _controller.Delete(request);

            // Assert
            await Assert.ThrowsAsync<Exception>(result);

        }
    }
}
