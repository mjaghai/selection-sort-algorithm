# Selection Sort in C#

The **selection sort** algorithm, written out by hand — no `Array.Sort`, no LINQ.

```
SelectionSort/
├── SelectionSort.sln
├── SelectionSort.csproj
├── Program.cs
└── .gitignore
```

## What it demonstrates

| Concept | Where |
|---|---|
| **Selection sort**, step by step | the nested `for` loops |
| Tracking the index of the current minimum | `int minIndex = i;` |
| Comparing every later element against it | `if (numbers[j] < numbers[minIndex])` |
| Swapping into place once per outer pass | `// تعویض دو عدد` |
| Loop bounds — inner loop starts at `i + 1` | `for (int j = i + 1; j < n; j++)` |
| Why the outer loop stops at `n - 1` | last element is already in place |

```csharp
for (int i = 0; i < n - 1; i++)
{
    int minIndex = i;
    for (int j = i + 1; j < n; j++)
    {
        if (numbers[j] < numbers[minIndex])
            minIndex = j;
    }
    // تعویض دو عدد
    int temp = numbers[minIndex];
    numbers[minIndex] = numbers[i];
    numbers[i] = temp;
}
```

Each outer pass finds the smallest remaining number and swaps it into position `i`.
After pass `i`, the first `i + 1` elements are final — which is why the outer loop
stops one short of the end.

**Complexity:** O(n²) time, O(1) extra space. Slower than `Array.Sort`, but it is the
clearest way to see how a comparison sort actually works.

## Running it

```bash
dotnet run
```

The program prompts in Persian, then prints the sorted numbers.

## Notes

This was a loose `i.cs` file in a folder called `unknown`, with no project file. It was
given a proper project so it can be cloned and run like everything else. The original
Persian comments are preserved as-is.

---

<div dir="rtl">

## الگوریتم مرتب‌سازی انتخاب (Selection Sort)

مرتب‌سازی انتخاب، **دستی و مرحله به مرحله** پیاده‌سازی شده — بدون `Array.Sort`.

**مفاهیمی که نشان می‌دهد:**

- **حلقه `for` تودرتو**
- **پیدا کردن اندیس کمترین مقدار** در هر پاس
- **جابه‌جایی (swap)** برای قرار دادن آن در جای درست
- **دلیل محدوده حلقه‌ها**: حلقه داخلی از `i + 1` شروع می‌شود و حلقه بیرونی تا `n - 1`
  ادامه دارد، چون بعد از هر پاس، عنصر اول تا خانه `i` نهایی شده است

هر پاس بیرونی کوچک‌ترین عدد باقی‌مانده را پیدا می‌کند و در جای `i` می‌گذارد.

**پیچیدگی:** زمان O(n²) و حافظه اضافی O(1).

**اجرا:**

```bash
dotnet run
```

**نکته:** این کد قبلاً یک فایل `i.cs` بدون پروژه بود. برای آن پروژه‌ای ساخته شد تا مثل
بقیه قابل اجرا باشد. کامنت‌های فارسی اصلی حفظ شده‌اند.

</div>
