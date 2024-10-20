﻿using Management.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Management.Controllers
{
	public class CatController : Controller
	{
		// GET: CatController
		public async Task<ActionResult> Index()
		{
			string apiUrl = "https://catfact.ninja/fact";


			HttpClient client = new HttpClient();

			var response = await client.GetStringAsync(apiUrl);
			var cat = JsonConvert.DeserializeObject<Cats>(response);

			return View(cat);
		}

		// GET: CatController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: CatController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: CatController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: CatController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: CatController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: CatController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: CatController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
