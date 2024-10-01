/*
year, yyyy, yy = Year
quarter, qq, q = Quarter
month, mm, m = month
dayofyear, dy, y = Day of the year
day, dd, d = Day of the month
week, ww, wk = Week
weekday, dw, w = Weekday
hour, hh = hour
minute, mi, n = Minute
second, ss, s = Second
millisecond, ms = Millisecond
microsecond, mcs = Microsecond
nanosecond, ns = Nanosecond
tzoffset, tz = Timezone offset
iso_week, isowk, isoww = ISO week
*/

SELECT GETDATE(), DATEPART(hh, GETDATE()), DATEADD(d, 100, GETDATE()),
    DATEDIFF(m, GETDATE(), DATEADD(d, 500, GETDATE()))
