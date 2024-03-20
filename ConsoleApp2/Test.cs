using Riok.Mapperly.Abstractions;

class Fruit {}
class Banana : Fruit {}
class Apple : Fruit {}

class BananaDto {}
class AppleDto {}

[Mapper]
partial class Mapper
{
    public static partial TTarget MapFruit<TTarget>(Fruit source);

    private static partial BananaDto MapBanana(Banana source);
    private static partial AppleDto MapApple(Apple source);
}