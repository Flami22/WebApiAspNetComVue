using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.ViewModel;
using WebApi.Domain.DTOs;
using WebApi.Domain.Model.EmployeeAggregate;

namespace WebApi.Controllers.v2
{
    [ApiController]
    [Route("api/v{version:apiVersion}/cadastroClientes")]
    [ApiVersion("2.0")]
    public class CadastroClientesController : ControllerBase
    {
        private readonly IEmployeeRepository _cadastroClientesRepository;
        private readonly ILogger<EmployeeController> _logger;
        private readonly IMapper _mapper;

        public cadastroCLientesController(ICadastroClientesRepository cadastroClientesRepository, ILogger<EmployeeController> logger, IMapper mapper)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add([FromForm] ClienteViewModel employeeView)
        {

            var filePath = Path.Combine("Storage", employeeView.Photo.FileName);

            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            employeeView.Photo.CopyTo(fileStream);

            var cliente = new Cliente(employeeView.Name, employeeView.Age, filePath);

            _cadastroClientesRepository.Add(clientes)

            return Ok();
        }

        [Authorize]
        [HttpPost]
        [Route("{id}/download")]
        public IActionResult DownloadPhoto(int id)
        {
            var cliente = _cadastroClientesRepository.Get(id);

            var dataBytes = System.IO.File.ReadAllBytes(employee.photo);

            return File(dataBytes, "image/png");
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult Search(int id)
        {
            var employess = _cadastroClientesRepository.Get(id);

            var employeesDTOS =clienter.Map<EmployeeDTO>(employess);

            return Ok(employeesDTOS);
        }
    }
}
