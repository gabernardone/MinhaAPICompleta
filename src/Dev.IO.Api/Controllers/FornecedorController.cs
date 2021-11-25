using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DevIO.Api.ViewModels;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace Dev.IO.Api.Controllers
{
    [Route("api/fornecedores")]
    public class FornecedorController : MainController
        {
            private readonly IFornecedorRepository _fornecedorRepository;
            private readonly IMapper _mapper;

            public FornecedorController(IFornecedorRepository fornecedorRepository, IMapper mapper)
            {
                _fornecedorRepository = fornecedorRepository;
                _mapper = mapper;
            }

            public async Task<IEnumerable<FornecedorViewModel>> ObterTodos()
            {
                var fornecedor = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos()) ;

               return fornecedor;
            }
        }
    
}