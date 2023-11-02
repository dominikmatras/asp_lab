using Microsoft.AspNetCore.Components.Forms;

namespace Laboratorium3___App.Models;

public interface IDateTimeProvider
{
    DateTime CurrentDataTimeProvider();
}