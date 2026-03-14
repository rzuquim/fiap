# Imagens Digitais

Imagem é uma representação de algo seja real ou abstrato.

Imagem digital: raster (bitmap) e vetorial.

## Tipos de imagem num jogo

- Texturas
- Sprites
- UX

Pixel: unidade mínima de construção da imagem digital com informação de cor

- picture element

> Hoje filtros de upscaling, ant-aliasing (possivelmente com IA) permitem melhor zoom além do limite do pixel

## Dimensões e Resulção

- ppi - Pixel per Inch
- Resolução (300 ppi x 72 ppi x 24 ppi) => não vemos diferença no projetor (que é 72ppi)

> **27 Polegadas**:  
>  1440p (109 PPI) é o padrão equilibrado,  
>  4K (160+ PPI) oferece imagem muito nítida mas exige scaling.  
> **32 Polegadas**:  
>  4K (135+ PPI) é o ideal.  
>  1080p (69 PPI) neste tamanho é considerado ruim.  
> **Monitores de Alta Definição (Apple/Pro):**  
>  Monitores 5K de 27" têm cerca de 218 PPI, considerado o padrão para alta nitidez.

## Vetor

- múltiplos elementos vetoriais (direção e magnitude)

- praticar: https://bezier.method.ac/

## GIMP

- [ ] remover background usando máscara
  - add / subtract to mask
- [x] rasterizar layer => apply layer mask
- [ ] remover chapéu com pincel
- [ ] adicionar cor de fundo da layer específica: sólida ou gradiente
- [ ] pintar com textura
- [ ] usar textura específica (de outra imagem) - define pattern
  - alterando escala e angulo
- [ ] editar gradiente: cores, radial,
- [ ] transform (resize) multiple layers
- [ ] smart object (?)
- [ ] adicionar imagem dentro da tela do switch
- [ ] pen tool (path tool)
- [ ] add Drop Shadow Filter on switch
- [ ] adicionar HSV
- [ ] outer glow no cogumelo usando o conta gotas pra pegar a cor do brilho do cogumelo: drop shadow
- [ ] mushroom shadow using gaussian blur over vector shape
- [ ] mushroom shadow using pencil over layer

## GIMP Shortcuts

- [x] aumentar / diminuir o tamanho do pincel: ] and [
- [ ] mover canvas
- [ ] zoom canvas
- [ ] criar grupo de layers
- [x] search and run command: /
