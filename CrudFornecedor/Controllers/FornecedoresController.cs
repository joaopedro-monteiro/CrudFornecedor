using CrudFornecedor.Data;
using CrudFornecedor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudFornecedor.Controllers;

public class FornecedoresController : Controller
{
    private readonly Context _context;

    public FornecedoresController(Context context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var fornecedores = await _context.Fornecedor.ToListAsync();

        return View(fornecedores);
    }

    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
            return NotFound();

        var fornecedor = await _context.Fornecedor.FindAsync(id);
        if (fornecedor == null)
            return NotFound();

        return View(fornecedor);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Fornecedor fornecedor)
    {
        if (!ModelState.IsValid)
            return View(fornecedor);

        fornecedor.Id = Guid.NewGuid();

        await _context.AddAsync(fornecedor);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id == null)
            return NotFound();

        var fornecedor = await _context.Fornecedor.FindAsync(id);
        if (fornecedor == null)
            return NotFound();

        return View(fornecedor);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, Fornecedor fornecedor)
    {
        if (id != fornecedor.Id)
            return NotFound();

        if (!ModelState.IsValid)
            return View(fornecedor);

        if (!await FornecedorExistsAsync(fornecedor.Id))
            return NotFound();

        _context.Update(fornecedor);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id == null)
            return NotFound();

        var fornecedor = await _context.Fornecedor.FindAsync(id);
        if (fornecedor == null)
            return NotFound();

        return View(fornecedor);
    }

    [HttpPost]
    [ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var fornecedor = await _context.Fornecedor.FindAsync(id);
        if (fornecedor == null)
            return NotFound();

        _context.Fornecedor.Remove(fornecedor);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    private async Task<bool> FornecedorExistsAsync(Guid id)
    {
        return await _context.Fornecedor.AnyAsync(e => e.Id == id);
    }
}