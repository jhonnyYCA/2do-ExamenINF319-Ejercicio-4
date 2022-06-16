namespace Library1

module fib =
    
    
    let fibonacci n =
      
      let mutable a = 0
      let mutable b = 1

      if n=1 then   printf "%d " a
      if n=2 then   printf "%d " a 
                    printf "%d " b
      if n>=3 then   
        for i in 1..n do
           printf "%d " a
       
           let mutable f = a+b
           a <- b
           b <- f

    let rec fibonacciRecursivo n =
        match n with
        | 0 | 1 -> n
        | n -> fibonacciRecursivo (n-1) + fibonacciRecursivo (n-2)     



type Class1() = 
    member this.X = "F#"
