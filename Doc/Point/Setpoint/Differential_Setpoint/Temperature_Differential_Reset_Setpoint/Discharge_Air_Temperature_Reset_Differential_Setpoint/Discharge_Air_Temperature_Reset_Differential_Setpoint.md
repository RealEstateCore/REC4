[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Differential_Setpoint](../../Differential_Setpoint.md) > [Temperature_Differential_Reset_Setpoint](../Temperature_Differential_Reset_Setpoint.md) > [Discharge_Air_Temperature_Reset_Differential_Setpoint](#)
# Discharge_Air_Temperature_Reset_Differential_Setpoint

**Display name:** Discharge Air Temperature Reset Differential Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Temperature_Reset_Differential_Setpoint;1

---


## Child interfaces
* [Discharge_Air_Temperature_High_Reset_Setpoint](Discharge_Air_Temperature_High_Reset_Setpoint.md)
* [Discharge_Air_Temperature_Low_Reset_Setpoint](Discharge_Air_Temperature_Low_Reset_Setpoint.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
