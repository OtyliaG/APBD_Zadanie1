public static int MaxValue(int[] numbers) {
    if (numbers == null || numbers.Length == 0)
        throw new ArgumentException("Array cannot be null or empty.");

    int max = numbers[0];
    for (int inna_zmienna = 1; inna_zmienna < numbers.Length; inna_zmienna++) {
        if (numbers[inna_zmienna] > max)
            max = numbers[inna_zmienna];
    }
    return max;
}