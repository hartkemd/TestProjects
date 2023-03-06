
type Throwable = {
    throw: () => void
}

type Bounceable = {
    bounce: () => void
}

type Ball = Throwable & Bounceable;

let tennisBall: Ball = {
    throw: () => {},
    bounce: () => {}
}
