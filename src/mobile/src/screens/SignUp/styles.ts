import { SafeAreaView } from 'react-native-safe-area-context';
import styled from "styled-components/native";
import { UserCircle } from 'phosphor-react-native'

export const Container = styled(SafeAreaView)`
  flex: 1;
  background-color: ${({ theme }) => theme.COLORS.GRAY_700};
  padding: 24px;
`

export const Content = styled.View`
  flex: 1;
  justify-content: center;
`

export const Icon = styled(UserCircle).attrs(({ theme, size=56 }) => ({
  size: size,
  color: theme.COLORS.GREEN_700
}))`
  align-self: center;
`