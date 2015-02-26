namespace ProjectEuler

type Aggregate() = 
    member this.multiplesOf (a:int, b:int) = 
        [0 .. 999]
        |> List.filter(fun x -> x % a = 0 || x % b = 0 )
        |> List.sumBy (fun x -> x)    

    member this.func2 (x:int) = 2*x*x - x/5 + 3