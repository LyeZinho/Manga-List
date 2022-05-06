//using System;
//using global::website_asp_net_and_dapperorm;
//MangaDb db = new MangaDb();
//dynamic data = db.ReadMangaAsc();
//db.SetMangaCapitolos("One Piece", 190);
//foreach (var manga in data)
//{
//    Console.WriteLine(manga);
//}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages(

);

app.Run();
