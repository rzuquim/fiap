# Nomenclatura

- **Primitivas** — Formas geométricas básicas usadas como ponto de partida para modelagem (cubo, esfera, cilindro,
  plano, cone, etc.).

- **Objeto** — Entidade independente na cena 3D. Pode conter geometria, luz, câmera ou outros dados. Possui
  transformações próprias (posição, rotação, escala).

- **Geometria / Malha (Mesh)** — Estrutura que define a forma de um objeto 3D através de vértices, arestas e faces.

- **Vértice (Vertex)** — Ponto no espaço tridimensional que compõe a malha.

- **Aresta (Edge)** — Linha que conecta dois vértices.

- **Face (Polygon / Face)** — Superfície formada por três ou mais vértices conectados.

- **Triângulo (Tri)** — Face composta por três vértices. Forma geométrica mínima de uma superfície 3D.

- **Quad (Quadrilateral)** — Face composta por quatro vértices. Estrutura comum em modelagem para facilitar edição e
  subdivisão.

- **N-gon** — Face com mais de quatro vértices.

---

# Estrutura da Malha

- **Loop de arestas (Edge Loop)** — Sequência contínua de arestas conectadas que percorrem a malha.

- **Ring de arestas (Edge Ring)** — Conjunto de arestas paralelas a um edge loop.

- **Topologia** — Organização e fluxo dos polígonos de uma malha.

- **Pole** — Vértice onde convergem mais ou menos de quatro arestas. Pode gerar deformações.

- **Flow (Fluxo de topologia)** — Direção natural das arestas na malha, importante para deformação e animação.

---

## Transformações

- **Translação (Move / Translate)** — Alteração da posição do objeto.

- **Rotação (Rotate)** — Alteração da orientação do objeto.

- **Escala (Scale)** — Alteração do tamanho do objeto.

- **Transform** — Termo geral para posição, rotação e escala.

- **Pivot / Origem** — Ponto central usado como referência para transformações.

---

## Edição de Modelos

- **Extrude** — Criação de nova geometria a partir de faces, arestas ou vértices existentes.

- **Inset** — Cria uma face menor dentro de uma face existente.

- **Bevel / Chamfer** — Arredondamento ou suavização de arestas.

- **Loop Cut** — Inserção de um novo edge loop na malha.

- **Subdivide** — Divisão de faces em polígonos menores.

- **Merge** — União de vértices.

- **Delete / Dissolve**

  - **Delete** remove geometria.
  - **Dissolve** remove elementos mantendo a superfície.

---

## Modificadores e Operações

- **Subdivision Surface** — Modificador que aumenta a densidade da malha e suaviza a forma.

- **Boolean** — Operação entre objetos (união, diferença ou interseção).

- **Mirror** — Espelha a geometria em um eixo.

- **Array** — Duplica a geometria repetidamente.

---

## Visualização e Cena

- **Viewport** — Área onde a cena 3D é visualizada e editada.

- **Wireframe** — Visualização apenas das arestas da malha.

- **Shading** — Forma como a superfície é exibida (sólido, material, render).

- **Camera** — Objeto que define o ponto de vista da renderização.

- **Light** — Fonte de iluminação da cena.

---

## Materiais e Superfície

- **Material** — Conjunto de propriedades visuais aplicadas à superfície (cor, reflexão, rugosidade etc.).

- **Shader** — Programa que define como a superfície reage à luz.

- **Texture** — Imagem usada para controlar propriedades do material.

- **UV Mapping** — Processo de projetar uma textura 2D sobre um objeto 3D.

---

## Outros Conceitos

- **Scene (Cena)** — Conjunto de todos os objetos, luzes, câmeras e configurações.

- **Hierarchy** — Relação pai-filho entre objetos.

- **Instance** — Objeto duplicado que compartilha os mesmos dados de geometria.

- **Render** — Processo de gerar a imagem final a partir da cena 3D.

- **Normals** — Vetores que indicam a direção “para fora” de uma face, usados para iluminação.

- **Smoothing / Smooth Shading** — Técnica para suavizar a aparência das faces.

---

Se desejar, posso também montar um **glossário focado em modelagem poligonal (poly modeling)**, que é o conjunto de
termos mais usado em aulas de Maya e Blender.
