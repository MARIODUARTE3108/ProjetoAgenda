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
    public class TelefoneController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(TelefoneCadastroModel model,
             [FromServices] TelefoneRepository telefoneRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {  
                    Telefone telefone = new Telefone();
                    telefone.Numero = model.Numero;
                    telefone.IdContato = model.IdContato;

                    telefoneRepository.Inserir(telefone);
                    TempData["Mensagem"] = "Telefone cadastrado com sucesso.";
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
            [FromServices] TelefoneRepository telefoneRepository)
        {
            var model = new TelefoneConsultaModel();

            try
            {
                model.Telefones = telefoneRepository.Consultar();
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Erro ao consultar os contatos." + e.Message;
            }

            return View(model);
        }

        public IActionResult Exclusao(Guid id,
            [FromServices] TelefoneRepository telefoneRepository)
        {
            try
            {
                var telefone = telefoneRepository.ObterPorId(id);

                telefoneRepository.Excluir(telefone);

                TempData["Mensagem"] = "Telefone excluído com sucesso.";
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Erro ao excluir o Telefone. " + e.Message;
            }
            return RedirectToAction("Consulta");

        }
        public IActionResult Edicao(Guid id,
            [FromServices] TelefoneRepository telefoneRepository)
        {
            var model = new TelefoneEdicaoModel();

            try
            {
                var telefone = telefoneRepository.ObterPorId(id);

                model.IdTelefone = telefone.IdTelefone;
                model.Numero = telefone.Numero;
                model.IdContato = telefone.IdContato;
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Erro ao exibir o telefone" + e.Message;
            }

            return View(model);
        }
        
        [HttpPost]
        public IActionResult Edicao(TelefoneEdicaoModel model,
            [FromServices] TelefoneRepository telefoneRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var telefone = telefoneRepository.ObterPorId(model.IdTelefone);

                    telefone.Numero = model.Numero;
                    telefone.IdContato = model.IdContato;

                    telefoneRepository.Alterar(telefone);
                    TempData["Mensagem"] = "Telefone atualizado com sucesso.";

                    return RedirectToAction("Consulta");
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = "Erro ao atualizar o produto: "+ e.Message;
                }
            }
            return View();
        }

    }
}
