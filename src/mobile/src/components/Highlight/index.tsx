import { Container, Title, Subtitle } from './styles'

type HightlightProps = {
  title: string
  subtitle?: string
}

export function Highlight({ title, subtitle }: HightlightProps) {
  return (
    <Container>
      <Title>{title}</Title>
      <Subtitle>{subtitle}</Subtitle>
    </Container>
  )
}