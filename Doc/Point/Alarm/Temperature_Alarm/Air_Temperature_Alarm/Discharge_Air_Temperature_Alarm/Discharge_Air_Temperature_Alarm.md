[Point](../../../../Point.md) > [Alarm](../../../Alarm.md) > [Temperature_Alarm](../../Temperature_Alarm.md) > [Air_Temperature_Alarm](../Air_Temperature_Alarm.md) > [Discharge_Air_Temperature_Alarm](#)
# Discharge_Air_Temperature_Alarm

**Display name:** Discharge Air Temperature Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Temperature_Alarm;1

---


## Child interfaces
* [High_Discharge_Air_Temperature_Alarm](High_Discharge_Air_Temperature_Alarm.md)
* [Low_Discharge_Air_Temperature_Alarm](Low_Discharge_Air_Temperature_Alarm.md)

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
