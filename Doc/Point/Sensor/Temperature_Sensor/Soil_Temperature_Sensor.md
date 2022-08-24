[Point](../../Point.md) > [Sensor](../Sensor.md) > [Temperature_Sensor](Temperature_Sensor.md) > [Soil_Temperature_Sensor](#)
# Soil_Temperature_Sensor

**Display name:** Soil Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Soil_Temperature_Sensor;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
