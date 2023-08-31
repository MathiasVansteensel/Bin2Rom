# Scrap mechanic ROM builder (BIN 2 ROM)

This is a small program that can take the content of any file and make a ROM out of in in scrap mechanic. The ROM has an address input and a value output, that's it. Give it an address and it'll output the value at said address (any address out of range will give 0). I'm currently writing this for a programmable pc i made to load some code onto it. It's (supposed to be, we''ll see how far i get) a command line tool so it can be invoked from a makefile or a batch script for assembling and converting with a single click. I'm also writing an assembler which will be available together with the workshop link for the pc if/when i (ever) finish it.

DISCLAMER:
this program is not written in the most efficient way, nor is it very feature-rich. This is meant to be used once or twice by myself (and anyone desperate enough to use this and not write their own version). I dont want to hear "Yeahhhh it could be 1ns faster by doing it like this \**continues obscure explanation of unreadable and goofy code*\*" (bug reports and valuable info is welcome tho)
