import { SafeAreaView } from 'react-native-safe-area-context';
import styled from "styled-components/native";
import { Code } from 'phosphor-react-native'

export const Container = styled(SafeAreaView)`
  flex: 1;
  background-color: ${({ theme }) => theme.COLORS.GRAY_700};
  padding: 24px;
`

export const Content = styled.View`
  flex: 1;
  justify-content: center;
`

export const Icon = styled(Code).attrs(({ theme }) => ({
  size: 56,
  color: theme.COLORS.ORANGE_700
}))`
  align-self: center;
`