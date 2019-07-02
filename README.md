# Introduction

Piet is a programming language in which programs look like abstract paintings. 
The language is named after Piet Mondrian, who pioneered the field of geometric
abstract art. The creator [dangermouse](http://www.dangermouse.net) would have liked to call the
language Mondrian, but someone beat him to it with a rather mundane-looking
scripting language.

![Composition with Red, Yellow and Blue. 1921, Piet Mondrian.](http://www.dangermouse.net/esoteric/piet/Mondrian.jpg)

*Composition with Red, Yellow and Blue.*
1921, Piet Mondrian.

## Language Concepts

### Codels
Piet code takes the form of graphics made up of the recognised colours. Individual
pixels of colour are significant in the language, so it is common for programs to
be enlarged for viewing so that the details are easily visible. In such enlarged
programs, the term "codel" is used to mean a block of colour equivalent to a
single pixel of code, to avoid confusion with the actual pixels of the enlarged
graphic, of which many may make up one codel.

## Syntax Elements

### Numbers
Each non-black, non-white colour block in a Piet program represents an integer
equal to the number of codels in that block. Note that non-positive integers
cannot be represented, although they can be constructed with operators. When
the interpreter encounters a number, it does not necessarily do anything with
it. In particular, it is not automatically pushed on to the stack - there is an
explicit command for that (see below).

The maximum size of integers is notionally infinite, though implementations may
implement a finite maximum integer size. An integer overflow is a runtime error,
and handling this will be implementation dependent. 

### Black Blocks and Edges
Black colour blocks and the edges of the program restrict program flow. If the
Piet interpreter attempts to move into a black block or off an edge, it is
stopped and the CC is toggled. The interpreter then attempts to move from its
current block again. If it fails a second time, the DP is moved clockwise one
step. These attempts are repeated, with the CC and DP being changed between
alternate attempts. If after eight attempts the interpreter cannot leave its
current colour block, there is no way out and the program terminates. 

### White Blocks
White colour blocks are "free" zones through which the interpreter passes
unhindered. If it moves from a colour block into a white area, the interpreter
"slides" through the white codels in the direction of the DP until it reaches a
non-white colour block. If the interpreter slides into a black block or an edge,
it is considered restricted (see above), otherwise it moves into the colour
block so encountered. Sliding across white blocks into a new colour does not
cause a command to be executed (see below). In this way, white blocks can be
used to change the current colour without executing a command, which is very
useful for coding loops. 

Sliding across white blocks takes the interpreter in a straight line until it
hits a coloured pixel or edge. It does not use the procedure described above
for determining where the interpreter emerges from non-white coloured blocks.

_Precisely what happens when the interpeter slides across a white block and
 hits a black block or an edge was not clear in the original specification.
My interpretation follows from a literal reading of the above text_:

* The interpreter "slides" across the white block in a straight line.
* If it hits a restriction, the CC is toggled. Since this results in no 
  difference in where the interpreter is trying to go, the DP is immediately
  stepped clockwise.
* The interpreter now begins sliding from its current white codel, in the new
  direction of the DP, until it either enters a coloured block or encounters
  another restriction.
* Each time the interpreter hits a restriction while within the white block, it
  toggles the CC and steps the DP clockwise, then tries to slide again. This
  process repeats until the interpreter either enters a coloured block (_where
  execution then continues_); or until the interpreter begins retracing its
  route. If it retraces its route entirely within a white block, there is no
  way out of the white block and execution should terminate.

## Commands
Commands are defined by the transition of colour from one colour block to the 
next as the interpreter travels through the program. The number of steps along 
the Hue Cycle and Lightness Cycle in each transition determine the command 
executed, as shown in the table at right. If the transition between colour 
blocks occurs via a slide across a white block, no command is executed. The 
individual commands are explained below.

| Hue change | None      | 1 Darker    | 2 Darker   |
|------------|-----------|-------------|------------|
| None	     | -         | push        | pop        |
| 1 Step     | add       | subtract    | multiply   |
| 2 Steps    | divide    | mod         | not        |
| 3 Steps    | greater   | pointer     | switch     |
| 4 Steps    | duplicate | roll        | in(number) |
| 5 Steps    | in(char)  | out(number) | out(char)  |

* **push**: Pushes the value of the colour block just exited on to the stack.
   Note that values of colour blocks are not automatically pushed on to the
   stack - this push operation must be explicitly carried out.

* **pop**: Pops the top value off the stack and discards it.

* **add**: Pops the top two values off the stack, adds them, and pushes the
  result back on the stack.

* **subtract**: Pops the top two values off the stack, calculates the second
*   top value minus the top value, and pushes the result back on the stack.

* **multiply**: Pops the top two values off the stack, multiplies them, and 
  pushes the result back on the stack.

* **divide**: Pops the top two values off the stack, calculates the integer 
  division of the second top value by the top value, and pushes the result
  back on the stack. If a divide by zero occurs, it is handled as an
  implementation-dependent error, though simply ignoring the command is
  recommended.

* **mod**: Pops the top two values off the stack, calculates the second top
  value modulo the top value, and pushes the result back on the stack. The
  result has the same sign as the divisor (the top value). If the top value is
  zero, this is a divide by zero error, which is handled as an implementation-dependent
  error, though simply ignoring the command is recommended. (See note below.)

* **not**: Replaces the top value of the stack with 0 if it is non-zero, and 1
  if it is zero.

* **greater**: Pops the top two values off the stack, and pushes 1 on to the
  stack if the second top value is greater than the top value, and pushes 0 if
  it is not greater.

* **pointer**: Pops the top value off the stack and rotates the DP clockwise
  that many steps (anticlockwise if negative).

* **switch**: Pops the top value off the stack and toggles the CC that many
  times (the absolute value of that many times if negative).

* **duplicate**: Pushes a copy of the top value on the stack on to the stack.

* **roll**: Pops the top two values off the stack and "rolls" the remaining
  stack entries to a depth equal to the second value popped, by a number of
  rolls equal to the first value popped. A single roll to depth n is defined as
  burying the top value on the stack n deep and bringing all values above it up
  by 1 place. A negative number of rolls rolls in the opposite direction. A
  negative depth is an error and the command is ignored. If a roll is greater
  than an implementation-dependent maximum stack depth, it is handled as an
  implementation-dependent error, though simply ignoring the command is
  recommended.

* **in**: Reads a value from STDIN as either a number or character, depending
  on the particular incarnation of this command and pushes it on to the stack.
  If no input is waiting on STDIN, this is an error and the command is ignored.
  If an integer read does not receive an integer value, this is an error and
  the command is ignored.

* **out**: Pops the top value off the stack and prints it to STDOUT as either a
  number or character, depending on the particular incarnation of this command.

Any operations which cannot be performed (such as popping values when not enough
are on the stack) are simply ignored, and processing continues with the next
command. 

_Note on the mod command_: In the original specification of Piet the result of
a modulo operation with a negative dividend (the second top value popped off
the stack) was not explicitly defined. I assumed that everyone would assume
that the result of (p mod q) would always be equal to ((p + Nq) mod q) for any
integer N. So:

     5 mod 3 = 2
     2 mod 3 = 2
    -1 mod 3 = 2
    -4 mod 3 = 2

The mod command is thus identical to floored division in Wikipedia's page on
the [modulus operation](https://en.wikipedia.org/wiki/Modulo_operation).

## Links
* http://www.dangermouse.net/esoteric/piet.html
* https://en.wikipedia.org/wiki/Piet_Mondrian
