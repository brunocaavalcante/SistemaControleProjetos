using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class ContaController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IContaService _contaService;
        private readonly IContaRepository _contaRepository;
        public ContaController(IMapper mapper,
                               IContaService contaService,
                               IContaRepository contaRepository)
        {
            _mapper = mapper;
            _contaService = contaService;
            _contaRepository = contaRepository;
        }

        public async Task<IActionResult> Index()
        {
           
            return View(_mapper.Map<IEnumerable<ContaViewModel>>( await _contaRepository.ObterContaOperacoes()));
        }

        // GET: Conta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Conta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Conta/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Conta/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Conta/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Conta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Conta/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}