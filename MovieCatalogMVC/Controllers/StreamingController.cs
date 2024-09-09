using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using MovieCatalogMVC.Common.PagedList;
using MovieCatalogMVC.Data;
using MovieCatalogMVC.Entities;
using MovieCatalogMVC.Extensions;
using MovieCatalogMVC.Models;

public class StreamingController : Controller
{
    private readonly MovieCatalogMVCContext _context;
    private readonly IMapper _mapper;
    private readonly IValidator<Streaming> _validator;

    public StreamingController(MovieCatalogMVCContext context, IMapper mapper, IValidator<Streaming> validator)
    {
        _context = context;
        _mapper = mapper;
        _validator = validator;
    }

    // GET: Streaming
    public async Task<IActionResult> Index(int? page)
    {
        int pageNumber = page ?? 1;

        var streamings = await _context.Streamings
            .OrderBy(g => g.Name)
            .GetPagedAsync(pageNumber);

        var streamingsModel = _mapper.Map<PagedResult<StreamingModel>>(streamings);

        return View(streamingsModel);
    }

    // GET: Streaming/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Streaming/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(StreamingModel streamingModel)
    {
        var streaming = _mapper.Map<Streaming>(streamingModel);
        var validator = await _validator.ValidateAsync(streaming);

        if (!validator.IsValid)
        {
            validator.AddToModelState(this.ModelState);
            return View(streamingModel);
        }

        _context.Add(streaming);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    // GET: Streaming/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id is null)
            return NotFound();

        var streaming = await _context.Streamings
            .FindAsync(id);

        if (streaming is null)
            return NotFound();

        var streamingModel = _mapper.Map<StreamingModel>(streaming);

        return View(streamingModel);
    }

    // POST: Streaming/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, StreamingModel streamingModel)
    {
        if (id != streamingModel.StreamingId)
            return NotFound();

        var streaming = _mapper.Map<Streaming>(streamingModel);
        var validator = await _validator.ValidateAsync(streaming);

        if (!validator.IsValid)
        {
            validator.AddToModelState(this.ModelState);
            return View(streamingModel);
        }

        _context.Update(streaming);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    // GET: Streaming/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id is null)
            return NotFound();

        var streaming = await _context.Streamings
            .FindAsync(id);

        if (streaming is null)
            return NotFound();

        var streamingModel = _mapper.Map<StreamingModel>(streaming);

        return View(streamingModel);
    }

    // POST: Streaming/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var streaming = await _context.Streamings.FindAsync(id);
        if (streaming is not null)
        {
            _context.Streamings.Remove(streaming);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }
}
