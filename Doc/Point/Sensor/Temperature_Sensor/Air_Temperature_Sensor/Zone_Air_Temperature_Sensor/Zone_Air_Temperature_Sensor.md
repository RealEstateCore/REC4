[Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Air_Temperature_Sensor](../Air_Temperature_Sensor.md) > [Zone_Air_Temperature_Sensor](#)
# Zone_Air_Temperature_Sensor

**Display name:** Zone Air Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Zone_Air_Temperature_Sensor;1

---


## Child interfaces
* [Average_Zone_Air_Temperature_Sensor](Average_Zone_Air_Temperature_Sensor.md)
* [Coldest_Zone_Air_Temperature_Sensor](Coldest_Zone_Air_Temperature_Sensor.md)
* [Warmest_Zone_Air_Temperature_Sensor](Warmest_Zone_Air_Temperature_Sensor.md)

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
