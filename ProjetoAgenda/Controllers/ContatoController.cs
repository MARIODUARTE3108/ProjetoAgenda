using Microsoft.AspNetCore.Mvc;
using ProjetoAgenda.Entities;
using ProjetoAgenda.Models;
using ProjetoAgenda.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(ContatoCadastroModel model,
            [FromServices] ContatoRepository contatoRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Contato contato = new Contato();
                    contato.Nome = model.Nome;

                    contatoRepository.Inserir(contato);
                    TempData["Mensagem"] = "Contato cadastrado com sucesso.";
                    ModelState.Clear();
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = "Erro ao cadastrar o contato." + e.Message;
                }
                
            }
            return View();
        }
        public IActionResult Consulta(
            [FromServices] ContatoRepository contatoRepository)
        {
            var model = new ContatoConsultaModel();

            try
            {
                model.Contatos = contatoRepository.Consultar();
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Erro ao consultar os contatos." + e.Message;
            }

            return View(model);
        }

        public IActionResult Exclusao(Guid id,
            [FromServices] ContatoRepository contatoRepository,
            [FromServices] TelefoneRepository telefoneRepository)
        {
            try
            {
                var contato = contatoRepository.ObterPorId(id);

                if (telefoneRepository.ObterQuantidadeNumeros(contato.IdContato)>0)
                {
                     TempData["Mensagem"]= "Para excluir o contato não pode ter número cadastrado.";
                }

                contatoRepository.Excluir(contato);

                TempData["Mensagem"] = "Contato excluído com sucesso.";
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Erro ao excluir o contato. " + e.Message;
            }
            return RedirectToAction("Consulta");

        }
        public IActionResult Edicao(Guid id,
            [FromServices] ContatoRepository contatoRepository)
        {
            var model = new ContatoEdicaoModel();

            try
            {
                var contato = contatoRepository.ObterPorId(id);

                model.IdContato = contato.IdContato;
                model.Nome = contato.Nome;
            }
            catch (Exception e )
            {
                TempData["Mensagem"] = "Erro ao exibir o contato" + e.Message;
            }

            return View(model);
        }
        [HttpPost] 
        public IActionResult Edicao(ContatoEdicaoModel model,
            [FromServices] ContatoRepository contatoRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var contato = contatoRepository.ObterPorId(model.IdContato);
                    
                    contato.Nome = model.Nome;
                   
                    contatoRepository.Alterar(contato);
                    TempData["Mensagem"] = "Contato atualizado com sucesso.";
                  
                    return RedirectToAction("Consulta");
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = "Erro ao atualizar o produto: "
                   + e.Message;
                }
            }
            return View();
        }

    }
}
