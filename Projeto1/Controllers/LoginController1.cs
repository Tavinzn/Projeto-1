﻿using Microsoft.AspNetCore.Mvc;
using Projeto1.Models;

namespace Projeto1.Controllers
{
    public class LoginController1 : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(String email, String senha)
        {
            var usuario = _usuarioRepositorio.ObterUsuario(email);
            if(usuario != null && usuario.Senha == senha)
            {
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Email ou senha inválido");
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioRepositorio.AdicionarUsuario(usuario);
                return RedirectToAction("Login");
            }
            return View(usuario);
        }
    }
}
