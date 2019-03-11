using CRUD.Business;
using CRUD.Entities;
using CRUD.Web.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Web.Mvc.Controllers
{
    public class PedidoController : Controller
    {
        public ActionResult Index(string perfil)
        {
            if (perfil == "restaurante")
                return RedirectToAction("Restaurante");
            if (perfil == "funcionario")
                return RedirectToAction("Funcionario");

            return View();
        }

        public ActionResult Restaurante()
        {
            var pedidoBusiness = new PedidoBusiness();
            var pedidos = pedidoBusiness.Recuperar();

            return View(pedidos);
        }

        public ActionResult Funcionario()
        {
            var empresaBusiness = new EmpresaBusiness();
            var empresas = empresaBusiness.RecuperarTodas();

            var vm = new FuncionarioVM
            {
                Empresas = empresas.Select(x => new SelectListItem
                {
                    Text = x.Nome,
                    Value = x.Id.ToString()
                })
            };

            return View(vm);
        }

        [HttpPost]
        public ActionResult RealizarPedido(FuncionarioVM pedidoVM)
        {
            var pedidoBusiness = new PedidoBusiness();
            var empresaBusiness = new EmpresaBusiness();
            
            var empresas = empresaBusiness.RecuperarTodas();

            var vm = new FuncionarioVM
            {
                Empresas = empresas.Select(x => new SelectListItem
                {
                    Text = x.Nome,
                    Value = x.Id.ToString()
                })
            };

            try
            {
                DateTime temp;
                if (pedidoVM.Horario.Date < DateTime.Now.Date && DateTime.TryParse(pedidoVM.Horario.ToString(), out temp))
                {
                    throw new Exception("Data menor que a atual ou inválida!");
                }

                pedidoBusiness.Salvar(ConverterViewModel(pedidoVM));

                ViewBag.ClasseAlert = "alert-success";
                ViewBag.Mensagem = "Pedido realizado com sucesso!";
            }
            catch (Exception ex)
            {
                ViewBag.ClasseAlert = "alert-danger";
                ViewBag.Mensagem = ex.Message;
            }

            return View("Funcionario", vm);
        }

        private Pedido ConverterViewModel(FuncionarioVM pedidoVM)
        {
            Pedido pedido = new Pedido();

            pedido.EmpresaId = pedidoVM.EmpresaId;
            pedido.Funcionario = pedidoVM.Funcionario;
            pedido.Tamanho = pedidoVM.Tamanho;
            pedido.Horario = pedidoVM.Horario;
            pedido.Arroz = pedidoVM.Arroz;
            pedido.Feijao = pedidoVM.Feijao;
            pedido.Refogado = pedidoVM.Refogado;
            pedido.Proteina = pedidoVM.Proteina;
            pedido.Salada = pedidoVM.Salada;

            return pedido;
        }
    }
}