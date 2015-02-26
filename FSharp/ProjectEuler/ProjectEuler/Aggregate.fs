namespace ProjectEuler

type Aggregate() = 
    member this.multiplesOf (a:int, b:int, range) = 
        range
        |> List.filter(fun x -> x % a = 0 || x % b = 0 )
        |> List.sumBy (fun x -> x)    
