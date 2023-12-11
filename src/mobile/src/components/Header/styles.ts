import styled from 'styled-components/native';
import { CaretLeft, XCircle } from 'phosphor-react-native';

export const Container = styled.View`
  width: 100%;

  flex-direction: row;
  align-items: center;
  justify-content: center;
`;

export const BackButton = styled.TouchableOpacity`
  flex: 1;
`;

export const SignOutButton = styled.TouchableOpacity`
  flex: 1;
`;

export const BackIcon = styled(CaretLeft).attrs(({ theme }) => ({
  color: theme.COLORS.WHITE,
  size: 32,
  weight: 'bold',
}))``;

export const SignOutIcon = styled(XCircle).attrs(({ theme }) => ({
  color: theme.COLORS.RED_DARK,
  size: 32,
  weight: 'bold',
}))``;