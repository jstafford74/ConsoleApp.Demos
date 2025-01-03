// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("********** - Date/Time Manipulation - **********");

// Empty DateTime
DateTime date = new DateTime();

// Create a DateTime from a specific date
var dateOfBirth = new DateTime(1974, 07, 01);
Console.WriteLine($"{nameof(dateOfBirth)}: {dateOfBirth}");
var exactDateOfBirth = new DateTime(1974, 07, 01, 12, 30, 45, DateTimeKind.Local);
Console.WriteLine($"{nameof(exactDateOfBirth)}: {exactDateOfBirth}");
Console.WriteLine($"Day of the week: {dateOfBirth.DayOfWeek}");
Console.WriteLine($"Day of the year: {dateOfBirth.DayOfYear}");
Console.WriteLine($"Time of day: {exactDateOfBirth.TimeOfDay}");
Console.WriteLine($"Ticks: {exactDateOfBirth.Ticks}");
Console.WriteLine($"Kind: {exactDateOfBirth.Kind}");




// Create DateTime from current timestamp
DateTime now = DateTime.Now;
//Console.WriteLine($"{nameof(now)}: {now}");

//Create DateTime from a stirng;
//Console.WriteLine("What is your DOB (MM/dd/yyyy)?");
//string dob = Console.ReadLine();
//var parsedDate = DateTime.Parse(dob);
//Console.WriteLine($"{nameof(parsedDate)}: {parsedDate}");
//Console.WriteLine($"Day of the week: {parsedDate.DayOfWeek}");
//Console.WriteLine($"Day of the year: {parsedDate.DayOfYear}");
//Console.WriteLine($"Time of day: {parsedDate.TimeOfDay}");
//Console.WriteLine($"Ticks: {parsedDate.Ticks}");
//Console.WriteLine($"Kind: {parsedDate.Kind}");

////Change format of DateTime
//Console.WriteLine($"{nameof(parsedDate)}: {parsedDate.ToString("dd/MM/yyyy")}");
//Console.WriteLine($"{nameof(parsedDate)}: {parsedDate.ToString("yyyy-MM-dd")}");
//Console.WriteLine($"{nameof(parsedDate)}: {parsedDate.ToString("dddd, MMMM dd yyyy")}");
//Console.WriteLine($"{nameof(parsedDate)}: {parsedDate.ToString("MMM yy")}");
//Console.WriteLine($"{nameof(parsedDate)}: {parsedDate:dd/MM/yyyy}");


////Add additional time to DateTime
//Console.WriteLine($"5 years from now is : {now.AddYears(5)}");
//Console.WriteLine($"5 hours from now is : {now.AddHours(5)}");
//Console.WriteLine($"5 minutes from now is : {now.AddMinutes(5)}");

Console.WriteLine("********** - DateTime Offset Manipulation - **********");
//UTC Coordinated Universal Time
//var utcNow = DateTime.UtcNow;
//Console.WriteLine($"{nameof(now)}: {now}");
//Console.WriteLine($"{nameof(utcNow)}: {utcNow}");
//var tz = TimeZoneInfo.Local.GetUtcOffset(utcNow);
//Console.WriteLine($"User Time Zone: {tz}");

//var dto = new DateTimeOffset(now, tz);
//Console.WriteLine($"User Time Zone with UTC Offset: {dto}");
//Console.WriteLine($"UTC Time of Action: {dto.UtcDateTime}");

//var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
//var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime,indiaTz);
//Console.WriteLine($"{nameof(indiaTz)}: {indiaTz}");

//Console.WriteLine($"Action was completed in India at: {indiaDateTime}");

Console.WriteLine("********** - Date only & Time only Manipulation - **********");

//DateOnly
var dateOnly = new DateOnly(1974, 07, 01);
var nextDay = dateOnly.AddDays(1);
var nextMonth = dateOnly.AddMonths(1);
var nextYear = dateOnly.AddYears(1);
var previousDay = dateOnly.AddDays(-1);
var decadeLater = dateOnly.AddYears(10);
var lastMonth = dateOnly.AddMonths(-1);

Console.WriteLine($"{nameof(dateOnly)}: {dateOnly}");
Console.WriteLine($"{nameof(nextDay)}: {nextDay}");
Console.WriteLine($"{nameof(nextMonth)}: {nextMonth}");
Console.WriteLine($"{nameof(nextYear)}: {nextYear}");
Console.WriteLine($"{nameof(previousDay)}: {previousDay}");
Console.WriteLine($"{nameof(decadeLater)}: {decadeLater}");
Console.WriteLine($"{nameof(lastMonth)}: {lastMonth}");

var DateOnlyFromDateTime = DateOnly.FromDateTime(now);
Console.WriteLine($"{nameof(DateOnlyFromDateTime)}: {DateOnlyFromDateTime}");


Console.WriteLine("What is your DOB (dd MMM yyyy)?");
string? dobDateOnly = Console.ReadLine();
var theDateOnly = DateOnly.ParseExact(dobDateOnly, "dd MMM yyyy", CultureInfo.InvariantCulture);
Console.WriteLine($"{nameof(theDateOnly)}: {theDateOnly}");

// TimeOnly
var timeNow = TimeOnly.FromDateTime(now);
Console.WriteLine($"{nameof(timeNow)}: {timeNow:hh:mm tt}");

// Date Comparisons
var date1 = new DateTime(1985, 11, 23);
var date2 = new DateTime(1985, 1, 20);

Console.WriteLine($" Is '{nameof(date1)}' equal? '{date1 == date2}");

