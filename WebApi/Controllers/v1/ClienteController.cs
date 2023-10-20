using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.ViewModel;
using WebApi.Domain.DTOs;
using WebApi.Domain.Model.Cliente;

namespace WebApi.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/cliente")]
    [ApiVersion("1.0")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ILogger<ClienteController> _logger;
        private readonly IMapper _mapper;

        public ClienteController(IClienteRepository clienteRepository, ILogger<ClienteController> logger, IMapper mapper)
        {
            _clienteRepository = clienteRepository ?? throw new ArgumentNullException(nameof(clienteRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add([FromForm] ClienteViewModel clienteView)
        {

            var filePath = Path.Combine("Storage", clienteView.Photo.FileName);

            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            clienteView.Photo.CopyTo(fileStream);

            var cliente = new Cliente(clienteView.Name, clienteView.Age, filePath);

            _clienteRepository.Add(cliente);

            return Ok();
        }

        [Authorize]
        [HttpPost]
        [Route("{id}/download")]
        public IActionResult DownloadPhoto(int id)
        {
            var cliente = _clienteRepository.Get(id);

            var dataBytes = System.IO.File.ReadAllBytes(cliente.photo);

            return File(dataBytes, "image/png");
        }

        [HttpGet]
        public IActionResult Get(int pageNumber, int pageQuantity)
        {
            _logger.Log(LogLevel.Error, "Teve um Erro");

            var clientes = _clienteRepository.Get(pageNumber, pageQuantity);

            _logger.LogInformation("Teste");

            return Ok(clientes);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Search(int id)
        {
            var clientes = _clienteRepository.Get(id);

            var ClientesDTOS = _mapper.Map<EmployeeDTO>(employess);

            return Ok(ClienteDTOS);
        }
    }
}
