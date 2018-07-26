using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Paginacion<T> : List<T>
{
    public int PageIndex { get; set; }
    public int TotalPages { get; set; }
    public int TotalR { get; set; }
    public Paginacion(List<T> items, int count, int pageIndex, int pageSize)
    {
        PageIndex = pageIndex;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        TotalR = count;
        this.AddRange(items);
    }
    public bool HasPreviousPage
    {//si ya no puede retroceder envia un false
        get
        {
            return (PageIndex > 1);
        }
    }
    public bool HasNextPage
    {//hasta haya como ir con siguiente
        get
        {
            return (PageIndex < TotalPages);
        }
    }

    public static async Task<Paginacion<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
    {
        var count = await source.CountAsync();
        var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        return new Paginacion<T>(items, count, pageIndex, pageSize);

    }

}
